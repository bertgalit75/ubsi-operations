import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/auth/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.less'],
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup = this.fb.group({
    username: [null, [Validators.required]],
    password: [null, [Validators.required]],
  });

  loginError: string;

  constructor(
    private fb: FormBuilder,
    private authService: AuthService,
    private router: Router
  ) {}

  ngOnInit(): void {}

  forgotPassword(): void {
    this.router.navigate(['account', 'forgot-password']);
  }

  login(): void {
    for (const i in this.loginForm.controls) {
      this.loginForm.controls[i].markAsDirty();
      this.loginForm.controls[i].updateValueAndValidity();
    }

    if (!this.loginForm.valid) {
      return;
    }

    const { email, password } = this.loginForm.value;

    this.loginError = null;

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
      }
    );
  }

  signup(): void {
    this.router.navigate(['signup']);
  }

  public checkIfAuthenticated(): void {
    if (!this.authService.isTokenValid()) {
      this.authService.logout();
      this.router.navigate(['login']);
    }
  }
}
