import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Curiousperson } from './curiousperson';
import { ContactService } from './contact.service';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent {


  persona: Curiousperson;

  constructor(private contactservice: ContactService, private _route: Router) { }

  addcontact = new FormGroup({
    Email: new FormControl("", [Validators.required,
    Validators.minLength(5),
    Validators.maxLength(80),
    Validators.pattern("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$"),
    Validators.email]),
    Name: new FormControl(""),
    Surname: new FormControl(""),
    Message: new FormControl(""),
    Subject: new FormControl(""),
    Phone: new FormControl()
  })



  Submit() {
    debugger;
    const contact = <Curiousperson>this.addcontact.value;
    this.contactservice.AddCurious(contact).subscribe((response) => {
      this.persona = response;
      console.log('Done getting persons', response)
      if (response == null) {
        alert('Some form is wrong, retry.');
      } else {
        alert('Message sent');
        this._route.navigate(['']);
      }
    });
  }



}
