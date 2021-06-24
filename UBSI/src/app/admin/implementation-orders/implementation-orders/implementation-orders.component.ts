import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-implementation-orders',
  templateUrl: './implementation-orders.component.html',
  styleUrls: ['./implementation-orders.component.less'],
})
export class ImplementationOrdersComponent implements OnInit {
  dataSet: any[] = [
    {
      ioNo: 'M12031',
      client: 'Unilever Philippines Inc',
      agency: 'Mindshare Philippines Inc',
    },
  ];

  constructor() {}

  ngOnInit(): void {}
}
