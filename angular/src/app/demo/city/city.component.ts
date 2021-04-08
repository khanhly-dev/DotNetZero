import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { from, Observable } from 'rxjs';
import {City } from '../viewModel/cityViewModel'
import { GetDataService } from '../get-data.service'
import { CityServiceProxy } from '@shared/service-proxies/service-proxies';

const ApiUrl = "https://605c56316d85de00170d9eb0.mockapi.io/city"

@Component({
  selector: 'app-city',
  templateUrl: './city.component.html',
  styleUrls: ['./city.component.css'], 
 
})
export class CityComponent implements OnInit {

  constructor(private getData : GetDataService,
    private cityServie: CityServiceProxy,
    ) { }

  ngOnInit(): void {
    //call api 
    this.cityServie.getAllCity().subscribe(result=>{
      console.log(result);
    })
    // this.getAllProduct()
  }

  cityList : City[] = []

  getAllProduct():void
  {
    this.getData.getAllProduct().subscribe(x => this.cityList = x)
  }
}
