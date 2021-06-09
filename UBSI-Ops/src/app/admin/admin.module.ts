import { NgModule } from "@angular/core";
import { MaterialModule } from "../shared/angular-material.module";
import { SharedModule } from "../shared/shared.module";
import { AdminRoutingModule } from "./admin-routing.module";
import { LayoutsModule } from "./layouts/layouts.module";

@NgModule({
  imports: [AdminRoutingModule, SharedModule,MaterialModule,LayoutsModule],
})
export class AdminModule{

}