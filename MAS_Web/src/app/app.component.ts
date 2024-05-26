import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MatIconModule } from '@angular/material/icon';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, MatIconModule, CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  isPaused : boolean = false;
  title = 'FWM_mas_trabajo';
  images = [
    'https://www.multitrabajos.com/company/static/media/bumi-desktop.8675eb37.png',
    'https://www.multitrabajos.com/company/static/media/aviso-gratis-desktop.72aed4ff.png',
    'https://www.multitrabajos.com/company/static/media/busqueda-en-base-desktop.fb8cea88.png',
    'https://www.multitrabajos.com/company/static/media/aviso-talento-desktop.44ad51ed.png',
    'https://www.multitrabajos.com/company/static/media/selecta-desktop.dcda7660.png'
  ];
  currentImage: string = this.images[0];
  private intervalId: any;
  ngOnInit() {
    let currentIndex = 0;
    this.intervalId = setInterval(() => {
      currentIndex = (currentIndex + 1) % this.images.length;
      this.currentImage = this.images[currentIndex];
    }, 5000); 
  }

  paused(){
    if(this.isPaused){
      this.isPaused= false;
    }else{
      this.isPaused= true ;
    }
  }


}
