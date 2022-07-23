import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Addaddress } from './addaddress';
import { Addressresponse } from './addressresponse';

@Injectable({
  providedIn: 'root'
})
export class AddressService {

  constructor(private http: HttpClient) { }





  AddAddress(address: Addaddress): Observable<Addressresponse> {
    debugger;
    console.log(address);
    return this.http.post<Addressresponse>('https://localhost:5001/api/Address/AddAddress', JSON.stringify(address));
  }




}
