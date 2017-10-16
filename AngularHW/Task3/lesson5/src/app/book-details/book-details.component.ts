import { Component, OnInit } from '@angular/core';
import {  Router , ActivatedRoute , NavigationEnd, Params, PRIMARY_OUTLET} from '@angular/router';
import { Subscription } from 'rxjs/Subscription';
import 'rxjs/add/operator/filter';
import 'rxjs/add/operator/switchMap';

import { Observable } from 'rxjs/Observable';

import { BooksService } from '../services/books.service';
import { Book } from '../models/book.model';



@Component({
    selector: 'app-book-details',
    templateUrl: './book-details.component.html',
    styleUrls: ['./book-details.component.css']
})
export class BookDetailsComponent implements OnInit 
{
    id: string;
    id1: string;
    book: Book;
     
    private sub: Subscription;

    
    
    constructor(private activatedRoute: ActivatedRoute,                
                private booksService: BooksService
               ) 
    {                                                            
    }
           
    ngOnInit() 
    { 
       

        this.sub = this.activatedRoute.params
        .switchMap(params => {
            this.id = params['id'];          
            return this.booksService.getBook(this.id);
        })
        .subscribe(res => this.book = res);
        
    }

        
    ngOnDestroy() 
    {
        this.sub.unsubscribe();
    }

   
}