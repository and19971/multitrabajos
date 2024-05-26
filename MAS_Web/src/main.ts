import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
import { AppComponent } from './app/app.component';
import { FooterComponent } from './app/components/footer/footer.component';

bootstrapApplication(AppComponent, appConfig)
  .catch((err) => console.error(err));
  bootstrapApplication(FooterComponent, appConfig)
  .catch((err) => console.error(err));
