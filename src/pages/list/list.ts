import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import {ContactPage} from '../contact/contact';
import { RiskFilterPipe } from '../../pipes/riskFilter/riskFilter';


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

  foods= [
    {
      foodName:'rauwe/ongeschilde groenten en fruit',
      alternative:'geschilde en grondig gewassen groenten en fruit',
      attrs: ['Verhoogd risico op toxoplasmose','Verhoogd risico op salmonella']
    },
    {
      foodName:'rauwe melk',
      alternative:'gepasteuriseerde of UHT-behandelde melk',
      attrs: ['Verhoogd risico op listeriose','Verhoogd risico op salmonella']
    },
    {
      foodName:'zachte kaas op basis van rauwe melk',
      alternative:'zachte kaas gemaakt van gepasteuriseerde of UHT-behandelde melk of alle harde kazen',
      attrs: ['Verhoogd risico op listeriose']
    },
    {
      foodName:'rauwe eieren',
      alternative:'doorbakken eieren, hardgekookt ei',
      attrs: ['Verhoogd risico op listeriose','Verhoogd risico op salmonella']
    },
    {
      foodName:'rauwe/niet volledig gaar vlees en vleeswaren',
      alternative:'doorbakken vlees, doorbakken of gekookte vleeswaren',
      attrs:['Verhoogd risico op listeriose','Verhoogd risico op salmonella','Verhoogd risico op toxoplasmose']
    },
    {
      foodName:'niet-voorverpakte vleeswaren',
      alternative:'voorverpakte vleeswaren',
      attrs:['Verhoogd risico op listeriose','Verhoogd risico op salmonella','Verhoogd risico op toxoplasmose']
    },
    {
      foodName:'artisanaal gerookt, gemarineerd of gezouten vlees',
      alternative:'voorverpakt gerookt, gemarineerd of gezouten vlees',
      attrs:['Verhoogd risico op listeriose','Verhoogd risico op salmonella','Verhoogd risico op toxoplasmose']
    },
    {
      foodName:'lever en lever-producten',
      alternative:'niet van toepassing',
      attrs:['rijk aan vitamine A']
    },
    {
      foodName:'rauw/ niet volledig gare vis',
      alternative:'doorbakken of gekookte vis',
      attrs:['Verhoogd risico op listeriose','Verhoogd risico op salmonella']
    },
    {
      foodName:'rauw/ niet volledig gare schaal-en schelpdieren',
      alternative:'gekookte schaal-en schelpdieren',
      attrs:['Verhoogd risico op listeriose','Verhoogd risico op salmonella']
    },
    {
      foodName:'gerookte, gemarineerde of gezouten vis',
      alternative:'vis uit blik',
      attrs:['Verhoogd risico op listeriose','Verhoogd risico op salmonella']
    },
    {
      foodName:'voorverpakte/ vacuümverpakte vis en vissalades',
      alternative:'vis uit blik',
      attrs:['Verhoogd risico op listeriose','Verhoogd risico op salmonella']
    },
    {
      foodName:'zelfgevangen vis, zoals paling',
      alternative:'vis uit blik',
      attrs:['Risico op te veel zware metalen']
    },
    {
      foodName:'roofvissen, zoals haai, zwaardvis, marlijn, tonijn',
      alternative:'tonijn uit blik',
      attrs:['Risico op te veel zware metalen']
    },
    {
      foodName:'alcoholhoudende dranken',
      alternative:'alcoholvrije dranken, mocktails',
      attrs:['Risico op schade aan de foetus']
    },
    {
      foodName:'kraanwater uit loden leidingen',
      alternative:'kraanwater in België/flessenwater',
      attrs:['Risico op te veel zware metalen']
    },
    {
      foodName:'onzuiver water',
      alternative:'kraanwater in België/flessenwater',
      attrs:['Risico op infecties']
    },
    {
      foodName:'koffie en thee',
      alternative:'maximum 1 tas koffie/dag, maximum 3 tasen thee/dag',
      attrs:['Rijk aan cafeïne']
    },
    {
      foodName:'> halve liter lightfrisdranken',
      alternative:'maximum halve liter/dag',
      attrs:['Verhoogd risico op te veel kunstmatige zoetstoffen']
    },
    {
      foodName:'> 1 glas dranken met kinine, zoals tonic, bitter lemon',
      alternative:'maximum 1 glas/dag',
      attrs:['Risico op schade aan de foetus']
    }
  ];
  
    options=
      [
        {name: 'Verhoogd risico op toxoplasmose', selected:false},
        {name: 'Verhoogd risico op listeriose', selected:false},
        {name: 'Verhoogd risico op salmonella', selected:false},
        {name: 'Rijk aan vitamine A', selected:false},
        {name: 'Risico op te veel zware metalen', selected:false},
        {name: 'Risico op schade aan de foetus', selected:false},
        {name: 'Risico op infecties', selected:false},
        {name: 'Rijk aan cafeïne', selected:false},
        {name: 'Verhoogd risico op te veel kunstmatige zoetstoffen', selected:false}
      ];

} 