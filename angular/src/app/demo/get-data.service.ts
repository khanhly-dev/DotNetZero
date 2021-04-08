import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { City } from './viewModel/cityViewModel';

const ApiUrl = "https://605c56316d85de00170d9eb0.mockapi.io/city"

@Injectable({
  providedIn: 'root'
})
export class GetDataService {

  constructor(private http: HttpClient) { }

  getAllProduct(): Observable<City[]>
  {
    return this.http.get<City[]>(ApiUrl).pipe()
  }
}
