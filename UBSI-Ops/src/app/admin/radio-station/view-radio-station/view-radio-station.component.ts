import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IRadioStation } from 'src/app/models/RadioStationModel';
import { RadioStationService } from 'src/app/services/radio-station.service';

@Component({
  selector: 'app-view-radio-station',
  templateUrl: './view-radio-station.component.html',
  styleUrls: ['./view-radio-station.component.css']
})
export class ViewRadioStationComponent implements OnInit {

  constructor(private route:ActivatedRoute,private radioStationService:RadioStationService) { }
  private stn_code =this.route.snapshot.paramMap.get('id');
  radioStation:IRadioStation
  ngOnInit(): void {
    this.getRadioStationDetails();
  }
  public getRadioStationDetails() {
    this.radioStationService.view(this.stn_code).subscribe(data=>{
      console.log(data);
      this.radioStation=data;
    })
    
  }
}
