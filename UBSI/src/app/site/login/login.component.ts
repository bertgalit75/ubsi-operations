import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { BehaviorSubject } from 'rxjs';
import { AuthGuard } from 'src/app/auth/auth.guard';
import { AuthService } from 'src/app/auth/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.less']
})
export class LoginComponent implements OnInit {
  loggingIn: BehaviorSubject<boolean> = new BehaviorSubject(null);

  loginError: string;

  constructor(private fb:FormBuilder,
    private authService: AuthService,
    private router: Router,
    private guard: AuthGuard) { }
  loginForm:FormGroup=this.fb.group({
    username:[null],
    password:[null]
  })
  ngOnInit(): void {
  }

  forgotPassword(): void {
    this.router.navigate(['account', 'forgot-password']);
  }

  login(): void {
    console.log(this.loginForm.value);
    if (!this.loginForm.valid) {
      return;
    }

    const { email, password } = this.loginForm.value;

    this.loginError = null;
    this.loggingIn.next(true);

    this.authService.login(email, password).subscribe(
      () => {
        if (this.authService.redirectUrl != null) {
          const attemptedUrl = this.authService.redirectUrl;
          this.authService.redirectUrl = null;
          this.router.navigateByUrl(attemptedUrl);
        } else {
          this.router.navigate(['']);
        }
      },
      (error) => {
        this.loginError = error;
        console.log(error);
        this.loggingIn.next(false);
      }
    );
  }

  signup() {
    this.router.navigate(['signup']);
  }
  public checkIfAuthenticated() {
    if (!this.authService.isTokenValid()) {
      this.authService.logout();
      this.router.navigate(['login']);
    }
  }

}
