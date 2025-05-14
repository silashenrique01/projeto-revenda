import { Component, OnInit } from '@angular/core';
import { ApiResponse } from 'src/app/models/ApiResponse';
import { Revenda } from 'src/app/models/Revenda';
import { RevendaService } from 'src/app/services/revenda.service';

@Component({
  selector: 'app-revenda',
  templateUrl: './revenda.component.html',
  styleUrls: ['./revenda.component.scss']
})
export class RevendaComponent implements OnInit {
  revendas: Revenda[] | null = [];
  constructor(private revendaService: RevendaService) { }

  ngOnInit() {
    this.getAllRevendas();
  }

  getAllRevendas(){
    this.revendaService.getAllRevendas().subscribe((res:ApiResponse<Revenda[]>) =>{
      this.revendas = res.data;
      console.log(this.revendas)
    }, (error) =>{
      console.error(error);
    });
  }

}
