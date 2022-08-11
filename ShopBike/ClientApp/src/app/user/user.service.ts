import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AddUser } from './adduser'
import { Getuser } from './getuser';
import { Removeuser } from './removeuser';
import { Userresponse } from './userresponse';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }



  AddUser(user: AddUser): Observable<Userresponse> {
    debugger;
    const headers = { 'content-type': 'application/json' }
    return this.http.post<Userresponse>('https://localhost:5001/api/User/AddUser', JSON.stringify(user), { 'headers': headers });

  }




  GetUser(user: Getuser): Observable<Userresponse> {
    debugger;
    return this.http.get<Userresponse>('https://localhost:5001/api/Personn/GetPerson/' + user.Email)

  }
}
