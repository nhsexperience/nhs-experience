[See docs](/docs/index.md)

To install
```
npm install --save-dev webpack
```
> Whether to use --save-dev or not depends on your use cases. 
> Say you're using webpack only for bundling, then it's suggested that you install it with --save-dev option since you're not going to include webpack in your production build. 
> Otherwise you can ignore --save-dev.

To Build

```
npm run build
```

This will build the node modules cache and run wepack and builds jekyll

To then run locally

```
bundle exec jekyll serve
```