
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';



import { PersonService } from '../person/person.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {



  constructor(private http: HttpClient, private _route: Router,
    private activedroute: ActivatedRoute) {
    this.goTo = this.goTo.bind(this);
    this.login = this.login.bind(this);
  }







  goTo() {
    this._route.navigate(['/Registrati']);
  }
  login() {
    this._route.navigate(['/Accedi']);
  }


  ngOnInit() {
    debugger;
    //this.getPersons();
  }

  /*getPersons() {
    debugger;
    this.personservice.getPersons().subscribe((response) => console.log(response),
      (error: any) => console.log(error),
      () => console.log('Done getting persons'));
  }*/
}
