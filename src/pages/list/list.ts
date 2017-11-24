import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import {ContactPage} from '../contact/contact';
import { NgModule } from '@angular/core';

@Component({
  selector: 'page-list',
  templateUrl: 'list.html'
})
export class ListPage {
  
  constructor(public navCtrl: NavController, public navParams: NavParams) {
    this.navCtrl = navCtrl
  }
  Contact(){
    this.navCtrl.push(ContactPage);
  }

  

} 