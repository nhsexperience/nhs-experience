const MiniCssExtractPlugin = require("mini-css-extract-plugin");
const CopyPlugin = require("copy-webpack-plugin");
const devMode = process.env.NODE_ENV !== "production";

const path = require('path');

module.exports = {
  entry: './src/index.js',
  output: {
    filename: 'js/main.js',
    path: path.resolve(__dirname, 'assets-webpack'),
    library: {
      name: 'nhsce',
      type: 'umd',
    },
  },
  optimization: {
    minimize: false,
  },
  module: {
    rules: [
      { 
        test: /\.css$/i,
        use: [
          //"style-loader", 
          MiniCssExtractPlugin.loader,
          "css-loader"],
      },
    ],
  },
  plugins: [].concat(
    [
      new MiniCssExtractPlugin(
      {
        // Options similar to the same options in webpackOptions.output
        // all options are optional
        filename: "css/[name].css",
        chunkFilename: "[id].css",
        ignoreOrder: false, // Enable to remove warnings about conflicting order
      }),
      new CopyPlugin({
        patterns: [
          { from: "node_modules/reveal.js-menu/", to: "reveal.js-menu/" },
          //{ from: "node_modules/reveal.js-menu/font-awesome/", to: "reveal.js-menu/font-awesome/" },
          //{ from: "node_modules/reveal.js-menu/menu.css", to: "reveal.js-menu/menu.css" },
        ],
      }),
    ]),
};