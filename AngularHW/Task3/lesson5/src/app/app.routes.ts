import { Route, Routes,RouterModule } from '@angular/router';
import { ModuleWithProviders } from "@angular/core";
import { BooksListComponent } from './books-list/books-list.component';
import { BookDetailsComponent } from './book-details/book-details.component';
import  {BreadCrumpsComponent} from './bread-crumps/bread-crumps.component';


const indexRoute: Route = {
    path: '',
    redirectTo: '/books',
    pathMatch: 'full'
};

//export const AppRoutes: Routes = [

   const   routes : Routes =
    [

    {
        path: 'books',
        /*
        data:
        {
             breadcrumb: "books"
        },
        */
        component: BooksListComponent,


    },
    {
        path: 'books/:id',
             
         component: BookDetailsComponent,
         
         data:
         {
              breadcrumb: "books/IntrestingBook"
         }
           
    },

   

    indexRoute,


   
];

export const routing: ModuleWithProviders = RouterModule.forRoot(routes);