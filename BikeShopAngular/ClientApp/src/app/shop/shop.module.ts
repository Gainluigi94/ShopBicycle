import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { PersonComponent } from '../person/person.component';
import { HomeComponent } from '../home/home.component';
import { UserComponent } from '../user/user.component';



@NgModule({
  declarations: [],
  imports: [
    CommonModule, HttpClientModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'Registrati', component: PersonComponent, pathMatch: 'full' },
      { path: 'Accedi', component: UserComponent, pathMatch: 'full' }

    ])
  ]
})
export class ShopModule { }
