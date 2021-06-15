import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { MainComponent } from "./layouts/main/main.component";
import { RadioStationComponent } from "./radio-station/radio-station/radio-station.component";

const routes: Routes = [
    {
      path: "",
      component: MainComponent,
      children: [
        {
          path: 'stations',
          component: RadioStationComponent,
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