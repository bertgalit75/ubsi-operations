import { Component, OnInit } from '@angular/core';
import { PageEvent } from '@angular/material/paginator';
import { Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Subject } from 'rxjs';
import { auditTime } from 'rxjs/operators';
import { PageOptions } from 'src/app/core/pageoptions/PageOptions';
import { RadioStationModel } from 'src/app/models/RadioStationModel';
import { RadioStationService } from 'src/app/services/radio-station.service';
@Component({
  selector: 'app-radio-station',
  templateUrl: './radio-station.component.html',
  styleUrls: ['./radio-station.component.css']
})
export class RadioStationComponent implements OnInit {
  dataSource:MatTableDataSource<RadioStationModel>;
  constructor(private radionStationService:RadioStationService) { }
  displayedColumns=["code","name"];
  
  totalPages: number;

  totalCount: number;

  pageIndex = 0;

  pageSize = 5;

  sort: Sort = {
    active: '',
    direction: '',
  };
  pagination: Subject<void> = new Subject();
  ngOnInit(): void {
    this.loadRadioStation();
    this.pagination.pipe(auditTime(200)).subscribe(() => {
      this.loadRadioStation();
    });
  }
  page(pageEvent: PageEvent): void {
    this.pageIndex = pageEvent.pageIndex;
    this.pagination.next();
  }
  public loadRadioStation(){
    const options = new PageOptions(
      this.pageIndex,
      this.pageSize,
      this.sort.active,
      this.sort.direction
    );
    this.radionStationService.list(options).subscribe(data=>{
      this.dataSource=new MatTableDataSource<RadioStationModel>(data.items);
      this.totalCount = data.totalCount;
    })
  }
  sortdata(sort: Sort): void {
    this.sort = sort;
    this.loadRadioStation();
  }

}
