import { Component, Input, input } from '@angular/core';
import {
  NgIf,
  NgFor,
  UpperCasePipe,
  CommonModule,
} from '@angular/common';

import { Hero } from '../hero';
import { HEROES } from '../mock-heroes';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-hero-detail',
  standalone: true,
  imports: [FormsModule, UpperCasePipe],
  templateUrl: './hero-detail.component.html',
  styleUrl: './hero-detail.component.css'
})
export class HeroDetailComponent {
  @Input() hero?: Hero;
  heroes = HEROES;
  selectedHero?: Hero;


  onSelect(hero: Hero): void {
    this.selectedHero = hero;
  }
}
