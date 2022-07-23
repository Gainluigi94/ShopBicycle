
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AddressService } from '../address/address.service';
import { Addaddress } from '../address/addaddress';
import { PersonService } from './person.service';
import { AddPerson } from './addperson';
import { PersonResponse } from './personresponse';


@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {

  addaddress: Addaddress;
  persona: PersonResponse;
  constructor(private personservice: PersonService, private addresservice: AddressService) {

  }
  ngOnInit() {

  }


  addperson = new FormGroup({
    Email: new FormControl(""),
    Name: new FormControl(""),
    Surname: new FormControl(""),
    Birth: new FormControl(""),
    Sex: new FormControl(""),
    Passwordd: new FormControl(""),
    Nation: new FormControl(""),
    Taxcode: new FormControl("")

  });


  getPersons() {
    this.personservice.getPersons().subscribe((response) => console.log(response),
      (error: any) => console.log(error),
      () => console.log('Done getting persons'));
  }


  addAddress = new FormGroup({
    Way: new FormControl(""),
    PostalCode: new FormControl(""),
    Common: new FormControl(""),
    Sidestreet: new FormControl(""),
    Numbercivic: new FormControl("")
  });



  OnSubmit() {

    debugger;
    const nuovapersona = <AddPerson>this.addperson.value;

    this.personservice.AddPerson(nuovapersona).subscribe((response) => {
      this.persona = response;
      console.log('Done getting persons')
    });
  }





}
