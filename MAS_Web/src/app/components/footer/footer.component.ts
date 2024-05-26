import { Component, OnInit } from '@angular/core';
import { MatSelectModule } from '@angular/material/select';
import { ExternalServiceService } from '../../services/external-service.service';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-footer',
  standalone: true,
  imports: [MatSelectModule,HttpClientModule,CommonModule ],
  templateUrl: './footer.component.html',
  styleUrl: './footer.component.css'
})

export class FooterComponent implements OnInit {
  data: any;
  constructor(private apiCountries: ExternalServiceService) { }
  ngOnInit() {
    this.apiCountries.getData().subscribe(response => {
      this.data = response;
    })
  }
}
