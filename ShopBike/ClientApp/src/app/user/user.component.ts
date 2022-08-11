import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { PersonService } from '../person/person.service';
import { PersonResponse } from '../person/personresponse';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  constructor(private personservice: PersonService, private _route: Router) { }

  userr: PersonResponse;



  addUser = new FormGroup({
    Email: new FormControl(""),
    Passwordd: new FormControl("")
  }
  );



  ngOnInit() {
  }



  OnSubmit() {
    debugger;
    const user = this.addUser.get('Email').value;
    const password = this.addUser.get('Passwordd').value;
    this.personservice.GetEmail(user, password).subscribe((response) => {

      this.userr = response;
      if (response == null) {
        alert('Email or Password wrong,please retry.')
      } else {
        alert('Welcome to BikeShop')
        this._route.navigate(['/Buy']);
      }

    });



  }




}
