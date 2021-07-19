import { Component, OnInit } from '@angular/core';

interface MenuItem {
  route: string;
  label: string;
  icon: string;
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
    route: 'roles',
    label: 'Roles',
    icon: 'team',
  },
  {
    route: 'account-executives',
    label: 'Account Executives',
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
