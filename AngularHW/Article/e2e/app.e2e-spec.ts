import { ArticlePage } from './app.po';

describe('article App', function() {
  let page: ArticlePage;

  beforeEach(() => {
    page = new ArticlePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
