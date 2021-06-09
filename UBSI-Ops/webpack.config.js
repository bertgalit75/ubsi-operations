module.exports = {
  module: {
    rules: [
      {
        test: /\.scss$/,
        use: [
          {
            loader: "postcss-loader",
            options: {
              postcssOptions: {
                ident: "postcss",
                syntax: "postcss-scss",
                plugins: ["postcss-import", "tailwindcss", "autoprefixer"],
              },
            },
          },
          {
            loader: "sass-loader",
          },
        ],
      },
    ],
  },
};
const TerserPlugin = require('terser-webpack-plugin');
module.exports = {
optimization: {
    minimize: false,
    minimizer: [new TerserPlugin()],
  },
};