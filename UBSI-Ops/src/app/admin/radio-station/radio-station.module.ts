import { NgModule } from "@angular/core";
import { MaterialModule } from "src/app/shared/angular-material.module";
import { SharedModule } from "src/app/shared/shared.module";
import { RadioStationComponent } from "./radio-station/radio-station.component";
import { ViewRadioStationComponent } from './view-radio-station/view-radio-station.component';

@NgModule({
    declarations: [
      RadioStationComponent,
      ViewRadioStationComponent,
    ],
    imports: [SharedModule,MaterialModule],
  })
export class RadioStationModule{

}