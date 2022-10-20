import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-arr',
  templateUrl: './arr.component.html',
  styleUrls: ['./arr.component.css']
})
export class ArrComponent implements OnInit {

  users = [10,24,35,67,89,56,11,4,8]; 

  employees = [
    {name:'mukesh'},
    {name:'radha'},
    {name:'jyoti'},
    {name:'prem'}
  ]

  constructor() { }

  ngOnInit(): void {
  }

}

 

