import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { FavoriteBooksService } from '../services/favorite-books.service';
import { FavoriteBook } from '../models/favorite.model';


@Component({
  selector: 'app-favorite-book',
  templateUrl: './favorite-book.component.html',
  styleUrls: ['./favorite-book.component.css']
  
})
export class FavoriteBookComponent implements OnInit {


  favoriteBooks$: Observable<FavoriteBook[]>
  constructor(private favoriteBooksService : FavoriteBooksService ) { }
  //constructor( ) { }
  
  

  ngOnInit() {
      this.favoriteBooks$ = this.favoriteBooksService.getBooks();
  }


}
