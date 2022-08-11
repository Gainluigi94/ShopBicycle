
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

import { Addperson } from './addperson';
import { Person } from './person';
import { PersonService } from './person.service';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {

  addperson: Addperson;

  constructor(private personservice: PersonService) {

  }

  ngOnInit() {

    this.getPersons();
  }

  getPersons() {
    this.personservice.getPersons().subscribe((response) => console.log(response),
      (error: any) => console.log(error),
      () => console.log('Done getting persons'));
  }
  addPerson = new FormGroup({
    email: new FormControl(""),
    name: new FormControl(""),
    surname: new FormControl(""),
    birth: new FormControl(""),
    sex: new FormControl(""),
    passwordd: new FormControl(""),
    nation: new FormControl(""),
    taxcode: new FormControl("")

  });

  OnRowInserting() {
    const newperson = <Addperson>this.addPerson.value;
    this.personservice.AddPerson(newperson).subscribe((response) => console.log(response),
      (error: any) => console.log(error), () => console.log('Done getting persons'));
  }





}
