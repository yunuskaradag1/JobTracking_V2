import { Component } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  constructor(private router: Router,private translate: TranslateService) {
    translate.setDefaultLang('tr');
  }
  defaultLanguageId = 1;
  defaultLang = "tr";
  currentLanguage = 0;
  ngOnInit() {

    this.defaultLang = navigator.language;
    var localLang = localStorage.getItem('lang');
    if (localLang) {
      var lang = this.defaultLang;
      if (localLang)
        lang = localLang;
      if (lang != null) {
        localStorage.setItem('lang', lang);
        this.translate.use(lang);

      }
    } else {
      if (this.defaultLang == 'tr') {
        var lang = this.defaultLang;
        localStorage.setItem('lang', lang);
        this.translate.use(lang);

      } else {
        var lang = 'en';
        localStorage.setItem('lang', lang);
        this.translate.use(lang);

      }
    }

    this.router.events.subscribe((evt) => {
      if (!(evt instanceof NavigationEnd)) {
        return;
      }
      window.scrollTo(0, 0);
    });
  }
}
