import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import {RegisterPage} from '../register/register';
import {LoginPage} from '../login/login';
import {ContactPage} from '../contact/contact';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  constructor(public navCtrl: NavController) {
    this.navCtrl = navCtrl
  }
  Contact(){
    this.navCtrl.push(ContactPage);
  }
  Register(){
    this.navCtrl.push(RegisterPage);
  }
  Login(){
    this.navCtrl.push(LoginPage);
  }
  
}
