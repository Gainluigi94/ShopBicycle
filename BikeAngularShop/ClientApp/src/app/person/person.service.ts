import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Addaddress } from '../address/addaddress';
import { Addressresponse } from '../address/addressresponse';
import { AddPerson } from './addperson';
import { PersonResponse } from './personresponse';

@Injectable({
  providedIn: 'root'
})
export class PersonService {

  constructor(private http: HttpClient) { }


  getPersons(): Observable<PersonResponse[]> {
    debugger;
    return this.http.get<PersonResponse[]>('https://localhost:5001/api/Person/GetAllPerson');
  }

  AddAddress(address: Addaddress): Observable<Addressresponse> {
    debugger;
    console.log(address);
    return this.http.post<Addressresponse>('https://localhost:5001/api/Address/AddAddress', JSON.stringify(address));
  }

  AddPerson(person: AddPerson): Observable<PersonResponse> {
    debugger;
    const headers = { 'content-type': 'application/json' }
    console.log(person);
    return this.http.post<PersonResponse>('https://localhost:5001/api/Person/AddPersona', JSON.stringify(person), { 'headers': headers });
  }







}
