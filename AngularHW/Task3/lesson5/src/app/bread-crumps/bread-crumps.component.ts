import { Component, OnInit } from '@angular/core';
import { BooksService} from  '../services/books.service'

import {  Router , ActivatedRoute , NavigationEnd, Params, PRIMARY_OUTLET} from '@angular/router';
import { Subscription } from 'rxjs/Subscription';
import 'rxjs/add/operator/filter';
import 'rxjs/add/operator/switchMap';

import { Observable } from 'rxjs/Observable';
import { Book } from '../models/book.model';



interface IBreadcrumb {
  label: string;
  params?: Params;
  url: string;
}


@Component({
  selector: 'app-bread-crumps',
  templateUrl: './bread-crumps.component.html',
  styleUrls: ['./bread-crumps.component.css']
})

export class BreadCrumpsComponent implements OnInit {

  public breadcrumbs: IBreadcrumb[];
  
  private id: string;
  private bookName: string ='';

  constructor (private activatedRoute: ActivatedRoute, 
               private router :  Router,
               private booksService: BooksService 
              )
  { 
        this.breadcrumbs = [];    
                                        
  }

  ngOnInit() {

    const ROUTE_DATA_BREADCRUMB: string = "breadcrumb";
    
        //subscribe to the NavigationEnd event
        this.router.events.filter(event => event instanceof NavigationEnd).subscribe(event => 
        {
          //set breadcrumbs
           let root: ActivatedRoute = this.activatedRoute.root;
           this.breadcrumbs = this.getBreadcrumbs(root);  
           // this.len =  this.breadcrumbs.length;
          // this.last = this.breadcrumbs[this.len - 1].label; 
         
        });
  }

  private getBreadcrumbs(route: ActivatedRoute, url: string="", breadcrumbs: IBreadcrumb[]=[]): IBreadcrumb[] 
  {
      const ROUTE_DATA_BREADCRUMB: string = "breadcrumb";

      //get the child routes
      let children: ActivatedRoute[] = route.children;

      //return if there are no more children
      if (children.length === 0) {
      return breadcrumbs;
      }

     
      //iterate over each children
      for (let child of children) 
      {
          //verify primary route
          if (child.outlet !== PRIMARY_OUTLET) {
              continue;
          }
          
          /*
          //verify the custom data property "breadcrumb" is specified on the route
          if (!child.snapshot.data.hasOwnProperty(ROUTE_DATA_BREADCRUMB)) {
              return this.getBreadcrumbs(child, url, breadcrumbs);
          }
        */
          //get the route's URL segment

          let routeURL: string = child.snapshot.url.map(segment => segment.path).join("/");
              
          
         
        
          //append route URL to URL
          url += `/${routeURL}`;
          
          //console.log('length' + url.toString()   + ' ' + urllastchar);
          console.log();
          this.booksService.getBook('1').subscribe(res =>  this.bookName = res.name );
          
          //add breadcrumb
          
          let breadcrumb: IBreadcrumb = {
              label: this.bookName,
              params: child.snapshot.params,
              url: url
          };
          breadcrumbs.push(breadcrumb);

          //recursive
          return this.getBreadcrumbs(child, url, breadcrumbs);
      }
  }
 
}
