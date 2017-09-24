import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-article-details',
  templateUrl: './article-details.component.html',
  styleUrls: ['./article-details.component.css']
})
export class ArticleDetailsComponent implements OnInit
 {

  constructor() { }
  ngOnInit() {  }

  articles: any [] = 
    [
      {
        id : 1,
        shortDescription:  "Режисер  кліпу  Rolling in  the  deep,  скейтер з   Іспанії та  оператор  на    роликах    з  Південної   Африки",
        title: "Як знімали  рекламу  Apple  в  Україні",  
        color: "black",
        chapter: null     
      },
 
      {
        id : 2,
        shortDescription:  "Захоплююча  історія, яка  не залишить    байдужим  навіть  найбільшого  скептика",
        title: "Пірати  Карибського  моря",  
        color: "black",
        chapter: null     
      },

      {
        id : 3,
        shortDescription:  "Суцільний    триллер, який  занурює в  інший  світ",
        title: "Інтерстеллер",  
        color: "black",
        chapter: null     
      }


    ]

    changeColor(obj: Article)
    {
        obj.color =  (obj.color === "black" ? "red" : "black");
    }

}


class Article 
{
  id: number;
  title: string;
  shortDescription: string;
  color: string;
  chapter: string;
}
