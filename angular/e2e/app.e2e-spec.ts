import { CSDLTemplatePage } from './app.po';

describe('CSDL App', function() {
  let page: CSDLTemplatePage;

  beforeEach(() => {
    page = new CSDLTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
