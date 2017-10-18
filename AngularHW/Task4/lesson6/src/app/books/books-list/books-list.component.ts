import { Component, Input, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs/Subscription';

import { IBook } from '../book';
import { BookService } from '../book.service';

@Component({
    selector: 'app-books-list',
    templateUrl: 'books-list.component.html'
})
export class BooksListComponent implements OnInit, OnDestroy {
    books: IBook[];
    favoriteMessage = '';
    imageWidth = 100;
    showImage = true;
    booksInStock = 2;
    errorMessage: string;

    private subscriptions: Subscription[] = [];

    constructor(private bookService: BookService) { }

    ngOnInit() {
        this.bookService.searchTerm$.subscribe((searchTerm: string) => this.updateBooks(searchTerm));
    }

    updateBooks(searchTerm: string) {
        this.bookService.getBooks(searchTerm)
            .subscribe(
            books => this.books = books,
            error => this.errorMessage = <any>error
            );
    }

    onFavoriteClicked(message: string): void {
        this.favoriteMessage = message;
    }

    toggleImage(): void {
        this.showImage = !this.showImage;
    }

    ngOnDestroy() {
        this.subscriptions.forEach(s => s.unsubscribe());
    }
}
