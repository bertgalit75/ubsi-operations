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
    route: 'buildings',
    label: 'Report',
    icon: 'summarize',
  },
   {
    route: 'stations',
    label: 'Radio Stations',
    icon: 'radio',
  },
  
];

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss'],
})
export class SidebarComponent implements OnInit {
  readonly menuItems: MenuItem[] = menuItems;

  constructor() {}

  ngOnInit(): void {}
}