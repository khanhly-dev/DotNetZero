import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CityComponent } from './city/city.component';
import { DistrictComponent } from './district/district.component'
import { Demo2RoutingModule } from './demo-routing.module';
import { TestComponent } from './test/test.component'

@NgModule({
  declarations: [
    CityComponent,
    DistrictComponent,
    TestComponent
  ],
  imports: [
    CommonModule,
    Demo2RoutingModule
  ]
})
export class Demo2Module { }
