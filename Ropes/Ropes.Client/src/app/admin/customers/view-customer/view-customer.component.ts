import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ICustomer } from 'src/app/models/customer.model';
import { CustomerService } from 'src/app/services/customer.service';

@Component({
  selector: 'app-view-customer',
  templateUrl: './view-customer.component.html',
  styleUrls: ['./view-customer.component.less'],
})
export class ViewCustomerComponent implements OnInit {
  constructor(
    private route: ActivatedRoute,
    private customerService: CustomerService
  ) {
    this.customerCode = this.route.snapshot.paramMap.get('code');
  }
  customerCode: string;
  customer: ICustomer;
  ngOnInit(): void {
    this.customerDetails();
  }
  customerDetails() {
    this.customerService
      .getCustomerDetails(this.customerCode)
      .subscribe((result) => {
        this.customer = result;
        console.log(result);
      });
  }
}
