import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
//import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { BooksListComponent } from './books/books-list/books-list.component';
import { TruncatePipe } from './shared/pipes/truncate.pipe';
import { FavoriteComponent } from './favorites/favorite.component';
import { BookService } from './books/book.service';
import { BookFakeService } from './books/book-fake.service';
import { HomeComponent } from './home/home.component';
import { BookDetailsComponent } from './books/book-details/book-details.component';
import { routing } from './app.routes';
import { EverySecondGuard } from './shared/guards/every-second.guard';
import { FormBuyBookComponent } from './books/form-buy-book/form-buy-book.component';
import { AddBookComponent } from './books/add-book/add-book.component';

@NgModule({
    imports: [
        BrowserModule,
        //FormsModule,
        ReactiveFormsModule,
        HttpModule,
        routing
    ],
    // providers: [{ provide: BookService, useClass: BookFakeService }],
    providers: [
        BookService,
        EverySecondGuard
    ],
    declarations: [
        AppComponent,
        BooksListComponent,
        BookDetailsComponent,
        FormBuyBookComponent,
        TruncatePipe,
        FavoriteComponent,
        HomeComponent,
        AddBookComponent
       
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }
