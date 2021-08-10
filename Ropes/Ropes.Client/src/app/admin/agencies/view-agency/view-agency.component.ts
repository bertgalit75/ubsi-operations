import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IAgency } from 'src/app/models/agency.model';
import { AgencyService } from 'src/app/services/agency.service';

@Component({
  selector: 'app-view-agency',
  templateUrl: './view-agency.component.html',
  styleUrls: ['./view-agency.component.less'],
})
export class ViewAgencyComponent implements OnInit {
  constructor(
    private route: ActivatedRoute,
    private agencyService: AgencyService
  ) {
    this.agencyCode = this.route.snapshot.paramMap.get('code');
  }
  agencyCode: string;
  agency: IAgency;
  ngOnInit(): void {
    this.customerDetails();
  }
  customerDetails() {
    this.agencyService.getAgencyDetails(this.agencyCode).subscribe((result) => {
      this.agency = result;
    });
  }
}
