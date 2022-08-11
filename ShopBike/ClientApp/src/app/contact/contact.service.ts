import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Curiousperson } from './curiousperson';

@Injectable({
  providedIn: 'root'
})
export class ContactService {

  constructor(private http: HttpClient) { }



  AddCurious(person: Curiousperson): Observable<Curiousperson> {
    debugger;
    console.log(person);
    const headers = { 'content-type': 'application/json' }
    return this.http.post<Curiousperson>('https://localhost:5001/api/Curiousperson/AddCuriousPerson', JSON.stringify(person), { 'headers': headers });
  }





}
