import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pipes',
  templateUrl: './pipes.component.html',
  styleUrls: ['./pipes.component.css']
})
export class PipesComponent implements OnInit {

  today: number = Date.now();

  a: number = 0.259;
  b: number = 1.3495;

  constructor() { }

  ngOnInit(): void {
  }

}
