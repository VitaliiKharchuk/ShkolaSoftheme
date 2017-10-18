import { Component } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
    selector: 'app-form-buy-book',
    templateUrl: 'form-buy-book.component.html'
})
export class FormBuyBookComponent {
    submitted = false;
    booksNumber = 1;

    buyBookForm: FormGroup;

    constructor(
        private fb: FormBuilder
    ) {
        this.buyBookForm = this.fb.group({
            booksNumber: [1, [
                Validators.required,
                c => c.value > 3 ? null : {
                    booksNumber: {
                        valid: false
                    }
                }]],
        });
    }
}