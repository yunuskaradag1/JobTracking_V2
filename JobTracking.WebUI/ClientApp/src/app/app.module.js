"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.createTranslateLoader = void 0;
var http_loader_1 = require("@ngx-translate/http-loader");
function createTranslateLoader(http) {
    return new http_loader_1.TranslateHttpLoader(http, '../assets/i18n/', '.json');
}
exports.createTranslateLoader = createTranslateLoader;
//# sourceMappingURL=app.module.js.map