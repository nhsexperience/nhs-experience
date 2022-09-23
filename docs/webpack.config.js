const path = require('path');

module.exports = {
  entry: './src/index.js',
  output: {
    filename: 'main.js',
    path: path.resolve(__dirname, 'assets', 'js'),
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
        use: ["style-loader", "css-loader"],
      },
    ],
  },
};