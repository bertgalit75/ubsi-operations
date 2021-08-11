import { Component, OnInit } from '@angular/core';

interface MenuItem {
  route: string;
  label: string;
  icon: string;
  subItems?: MenuItem[];
}

const menuItems: MenuItem[] = [
  {
    route: '.',
    label: 'Dashboard',
    icon: 'dashboard',
  },
  {
    route: 'implementation-orders',
    label: 'Implementation Orders',
    icon: 'dashboard',
  },
  {
    route: 'billing-statements',
    label: 'Billing Statements',
    icon: 'team',
  },
  {
    route: null,
    label: 'Accounts',
    icon: 'team',
    subItems: [
      {
        route: 'customers',
        label: 'Customers',
        icon: 'summarize',
      },
      {
        route: 'agencies',
        label: 'Agencies',
        icon: 'team',
      },
      {
        route: 'account-executives',
        label: 'Account Executives',
        icon: 'team',
      },

      {
        route: 'radio-stations',
        label: 'Radio Stations',
        icon: 'team',
      },
    ],
  },
  {
    route: null,
    label: 'Security',
    icon: 'team',
    subItems: [
      {
        route: 'users',
        label: 'Users',
        icon: 'team',
      },
      {
        route: 'roles',
        label: 'Roles',
        icon: 'summarize',
      },
    ],
  },
  {
    route: 'certificates-of-performance',
    label: 'Certificates of Performance',
    icon: 'team',
  },
];

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.less'],
})
export class SidebarComponent implements OnInit {
  readonly menuItems: MenuItem[] = menuItems;

  constructor() {}

  ngOnInit(): void {}
}
