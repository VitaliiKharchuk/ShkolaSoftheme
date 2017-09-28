import { Component } from '@angular/core';
import { ArticleDetailsComponent } from './article-details/article-details.component';

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
//import {FormsModule} from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],

  //directives: [ArticleDetailsComponent];
})
export class AppComponent {
  title = 'app';
}

