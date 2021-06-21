import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { MainComponent } from "./layouts/main/main.component";
import { RadioStationComponent } from "./radio-station/radio-station/radio-station.component";
import { ViewRadioStationComponent } from "./radio-station/view-radio-station/view-radio-station.component";

const routes: Routes = [
    {
      path: "",
      component: MainComponent,
      children: [
        {
          path: 'stations',
          component: RadioStationComponent,
        },
        {
          path: 'stations/:id',
          component: ViewRadioStationComponent,
        },
      ],
    },
  ];
@NgModule({
imports: [RouterModule.forChild(routes)],
exports: [RouterModule],
})
export class AdminRoutingModule{

}