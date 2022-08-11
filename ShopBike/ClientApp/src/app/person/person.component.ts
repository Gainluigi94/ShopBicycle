
import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, ValidationErrors, ValidatorFn, Validators } from '@angular/forms';

import { PersonService } from './person.service';
import { AddPerson } from './addperson';
import { PersonResponse } from './personresponse';

import { Router } from '@angular/router';


@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {

  persona: PersonResponse;
  submitted = false;

  constructor(private personservice: PersonService, private _route: Router) {

  }
  ngOnInit() {

  }


  addpersonn = new FormGroup({
    Email: new FormControl("", [Validators.required,
    Validators.minLength(5),
    Validators.maxLength(80),
    Validators.pattern("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$"),
    Validators.email]),
    Name: new FormControl(""),
    Surname: new FormControl(""),
    Birth: new FormControl(""),
    Way: new FormControl(""),
    Gender: new FormControl(""),
    Passwordd: new FormControl("", [
      Validators.required,
      Validators.minLength(5),
      Validators.maxLength(12)
    ]
    ),
    Nation: new FormControl(""),
    Taxcode: new FormControl(""),
    PostalCode: new FormControl(""),
    Common: new FormControl(""),
    NumberStreet: new FormControl(),
    Telephonenumber: new FormControl(),

  });

  get f(): { [key: string]: AbstractControl } {
    return this.addpersonn.controls;
  }

  getPersons() {
    this.personservice.getPersons().subscribe((response) => console.log(response),
      (error: any) => console.log(error),
      () => console.log('Done getting persons'));
  }




  OnSubmit() {

    debugger;
    this.submitted = true;
    const nuovapersona = <AddPerson>this.addpersonn.value;
    this.personservice.AddPerson(nuovapersona).subscribe((response) => {
      this.persona = response;
      console.log('Done getting persons', response)
      if (response == null) {
        alert('Email already exsist,please retry.')
        this._route.navigate(['/Create']);
      } else {
        alert('Congrats.Account Created')
        this._route.navigate(['']);
      }
    });




  }

  private ControlValue(first: string, second: string) { }



}
