
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

  constructor(private personservice: PersonService, private _route: Router) {

  }
  ngOnInit() {

  }


  addpersonn = new FormGroup({
    Email: new FormControl("", Validators.required),
    Name: new FormControl(""),
    Surname: new FormControl(""),
    Birth: new FormControl(""),
    Way: new FormControl(""),
    Sex: new FormControl(""),
    Passwordd: new FormControl("",Validators.required),
    Nation: new FormControl(""),
    Taxcode: new FormControl(""),
    PostalCode: new FormControl(""),
    Common: new FormControl(""),
    Sidestreet: new FormControl(""),
    Numbercivic: new FormControl(""),

  },{
  
  });

  

  get f(){
    return this.addpersonn.controls;
  }




  getPersons() {
    this.personservice.getPersons().subscribe((response) => console.log(response),
      (error: any) => console.log(error),
      () => console.log('Done getting persons'));
  }




  OnSubmit() {

    debugger;
    const nuovapersona = <AddPerson>this.addpersonn.value;

    this.personservice.AddPerson(nuovapersona).subscribe((response) => {

      this.persona = response;
      console.log('Done getting persons')
    });
    this._route.navigate(['']);
  }

  ConfirmedValidator(controlName: string, matchingControlName: string){
    return (formGroup: FormGroup) => {
        const control = formGroup.controls[controlName];
        const matchingControl = formGroup.controls[matchingControlName];
        if (matchingControl.errors && !matchingControl.errors.confirmedValidator) {
            return;
        }
        if (control.value !== matchingControl.value) {
            matchingControl.setErrors({ confirmedValidator: true });
        } else {
            matchingControl.setErrors(null);
        }
    }
}


}
