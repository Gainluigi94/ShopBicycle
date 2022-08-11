import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Addperson } from './addperson';
import { Personresponse } from './personresponse';

@Injectable({
  providedIn: 'root'
})
export class PersonService {

  constructor(private http: HttpClient) { }


  getPersons(): Observable<Personresponse[]> {
    debugger;
    return this.http.get<Personresponse[]>('https://localhost:5001/api/Person/GetAllPerson');
  }


  AddPerson(person: Addperson): Observable<Personresponse> {
    debugger;
    console.log(person);
    return this.http.post<Personresponse>('https://localhost:5001/api/Person/AddPersona', JSON.stringify(person));
  }







}
