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
    route: 'buildings',
    label: 'Report',
    icon: 'summarize',
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
