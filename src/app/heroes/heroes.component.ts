import {Component} from '@angular/core';
import {
  NgIf,
  NgFor,
  UpperCasePipe,
  CommonModule,
} from '@angular/common';
import {FormsModule} from '@angular/forms';

import { Hero } from '../hero';
import { HEROES } from '../mock-heroes';

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css'],
  standalone: true,
  imports: [FormsModule, UpperCasePipe]
})
export class HeroesComponent {
  heroes = HEROES;
  selectedHero?: Hero;

  onSelect(hero: Hero): void {
    this.selectedHero = hero;
  }
}
