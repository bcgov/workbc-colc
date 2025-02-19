/*global module*/


module.exports = function (grunt) {
  'use strict';

  // Load grunt tasks automatically
  require('load-grunt-tasks')(grunt);

  grunt.initConfig({
    pkg: this.file.readJSON('package.json'),

    info: {
      sourceDir: 'src',
      docsDir: 'docs'
    },


    clean: {
      docs: ['<%= info.docsDir %>']
    },


    jshint: {
      options: {
        force: true,
        jshintrc: '.jshintrc'
      },
      all: [
        'Gruntfile.js',
        '<%= info.sourceDir %>/**/*.js'
      ]
    },


    jsbeautifier: {
      files: ['<%= jshint.all %>'],
      options: {
        js: {
          braceStyle: 'end-expand',
          breakChainedMethods: false,
          e4x: false,
          evalCode: false,
          indentChar: ' ',
          indentLevel: 0,
          indentSize: 2,
          indentWithTabs: false,
          jslintHappy: true,
          keepArrayIndentation: false,
          keepFunctionIndentation: true,
          maxPreserveNewlines: 4,
          preserveNewlines: true,
          spaceBeforeConditional: true,
          spaceInParen: false,
          unescapeStrings: false,
          wrapLineLength: 0
        }
      }
    },

    docco: {
      build: {
        src: ['src/*.js'],
        options: {
          layout: 'linear',
          output: 'docs/'
        }
      }
    },

    version: {
      options: {
        prefix: '[@\'"]+version[\'"]*?\\s*[:=]*\\s*[\'"]*'
      },
      set: {
        src: ['package.json', 'bower.json', 'README.md', 'README.html', 'src/ODC.js']
      }
    },

    watch: {
      js: {
        options: {
          livereload: true
        },
        files: ['<%= jshint.all %>'],
        tasks: ['js']
      }
    }

  });


  grunt.registerTask('js', [
    'jsbeautifier',
    'jshint'
  ]);


  grunt.registerTask('docs', [
    'clean:docs',
    'docco'
  ]);

  return this.registerTask('default', ['js', 'docs']);
};
