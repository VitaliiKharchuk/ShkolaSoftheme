import { Component, OnInit } from '@angular/core';
import {FormGroup,  FormControl, Validators} from  '@angular/forms'
import { BookService } from '../book.service';

import { IBook } from '../book';

@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css']
})
export class AddBookComponent implements OnInit {

  constructor(private bookService: BookService) { }

  ngOnInit() {
  }



    bookForm = new  FormGroup(
      {
          title: new  FormControl(null,[Validators.required,  Validators.maxLength(100)]),
          auther:  new  FormControl(null,[Validators.required, Validators.maxLength(100) ] ),
          description:  new  FormControl(null,[Validators.required, Validators.maxLength(100)] ) 
      }
    )


   onSubmit()
   {
    
          let  newBook: IBook =  {
                                    id: "0",
                                    name : this.bookForm.value['title'],
                                    productCode : null, 
                                    releaseDate : null ,
                                    description: this.bookForm.value['description'],
                                    author :  this.bookForm.value['auther'],
                                    genre: null,
                                    specifications:null,
                                    inStock : false,
                                    price : null,
                                    starRating : null,
                                    imageUrl : null,
                                 };
      

                                 this.bookService.putBook(newBook).subscribe();
      
        this.bookService.putBook(newBook).subscribe(
           data => {
             // refresh the list
             this.bookService.getAllBooks();
             return true;
           }
        );

      
      //console.log( newBook );
      

   }


}




