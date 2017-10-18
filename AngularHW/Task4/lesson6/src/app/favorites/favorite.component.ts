import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
    selector: 'app-favorite',
    templateUrl: 'favorite.component.html'
})
export class FavoriteComponent {
    fave = false;

    @Input() favorite: string;
    @Input() reviews: number;
    @Output() favoriteClicked: EventEmitter<string> = new EventEmitter<string>();

    onClick(): void {
        this.favoriteClicked.emit(`The favorite ${this.favorite} was saved`);
        this.fave = !this.fave;
    }

    isSelected(fave: boolean): boolean {
        if (!fave || !this.fave) {
            return false;
        }
        if (fave) {
            return true;
        }
    }
}
